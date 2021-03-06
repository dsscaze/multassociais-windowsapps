﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace MultasSociais.Lib.Models
{
    public class GrupoDeMultas
    {
        private readonly ObservableCollection<Multa> itens = new ObservableCollection<Multa>();
        private IEnumerable<Multa> itensTop = new List<Multa>();
        private int topCount = 4;
        public int TopCount
        {
            get { return topCount; }
            set
            {
                topCount = value;
                SetItensTop();
            }
        }

        public GrupoDeMultas(TipoGrupo tipoGrupo)
        {
            Nome = ObterNome(tipoGrupo);
            TipoGrupo = tipoGrupo;
        }

        public void Add(IEnumerable<Multa> multas)
        {
            foreach (var multa in multas)
            {
                multa.Grupo = this;
                itens.Add(multa);
            }
            SetItensTop();
        }

        private void SetItensTop()
        {
            itensTop = (from m in itens
                        orderby m.DataOcorrencia descending
                        select m).Take(TopCount);
        }

        public void Add(params Multa[] multas)
        {
            Add((IEnumerable<Multa>) multas);
        }

        public ObservableCollection<Multa> Itens { get { return itens; } }
        public IEnumerable<Multa> ItensTop { get { return itensTop; } }
        public string Nome { get; private set; }
        public TipoGrupo TipoGrupo { get; private set; }

        public static string ObterNome(TipoGrupo tipoGrupo)
        {
            var nome = "";
            switch (tipoGrupo)
            {
                case TipoGrupo.MaisNovos:
                    nome = "Mais novos";
                    break;
                case TipoGrupo.MaisMultados:
                    nome = "Mais multados";
                    break;
            }
            return nome;
        }
    }
}

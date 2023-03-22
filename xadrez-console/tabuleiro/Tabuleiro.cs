﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xadrez_console.tabuleiro
{
    class Tabuleiro
    {
        public int linha { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas { get; set; }

        public Tabuleiro(int linha, int colunas)
        {
            this.linha = linha;
            this.colunas = colunas;
            pecas = new Peca[linha, colunas];
        }
    }
}

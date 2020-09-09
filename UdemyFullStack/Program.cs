﻿using System;
using UdemyFullStack.Lib;

namespace UdemyFullStack
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoFODA(
                new Jogador1(),
                new Jogador2()
            );

            jogo.IniciarJogo();
        }
    }
    
}

using System;
using System.Collections.Generic;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.Fundamentos;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos" , Comentarios.Executar},
                {"Variáveis e Constantes - Fundamentos" , VariaveisEConstantes.Executar},
                {"Inferencia de Tipos - Fundamentos" , Inferencia.Executar},
                {"Inteporlação - Fundamentos" , Interpolacao.Executar},
                {"Notação Ponto - Fundamentos" , NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos" , LendoDados.Executar},
                {"Formatando Números - Fundamentos" , FormatandoNumero.Executar},
                {"Conversões - Fundamentos" , Conversoes.Executar},
                {"Operadores Aritmeticos - Fundamentos" , OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - Fundamentos" , OperadoresRelacionais.Executar},
                {"Operadores Unarios - Fundamentos" , OperadoresUnarios.Executar},
                {"Operadores Ternarios - Fundamentos" , OperadorTernarios.Executar},
                
                //Estrutuas de Controle de Fluxo
                
                {"Estrutura IF- Estrutura de Controle" , Estruturaif.Executar},
                {"Estrutura Switch Case - Estrutura de Controle" , EstrutraSwitchCase.Executar},
                {"Estrutura While - Estrutura de Controle" , EstruturaWhile.Executar},
                {"Estrutura For - Estrutura de Controle" , EstruturaFor.Executar},
                {"Estrutura For Each- Estrutura de Controle" , EstruturaForEach.Executar},
                
                //Classes e metodos
                
                {"Membros - Classes e Metodos" , Membros.Executar},
                {"Construtores - Classes e Metodos" , Construtores.Executar},
                {"Metodos com Retorno - Classes e Metodos" , MetodosComRetorno.Executar},
                {"Metodos Estáticos - Classes e Metodos" , MetodosEstaticos.Executar},
                {"Atributos Estáticos - Classes e Metodos" , AtributosEstaticos.Executar},
                {"Desafio Atributo - Classes e Metodos" , DesafioAtributo.Executar},
                {"Params - Classes e Metodos" , Params.Executar},
                {"Parametros Nomeados - Classes e Metodos" , ParametrosNomeados.Executar},
                {"Getter e Setters - Classes e Metodos" , GetSet.Executar},
                {"Props - Classes e Metodos" , Props.Executar},
                {"Readonly - Classes e Metodos" , Props.Executar},
                {"Exemplos Enums - Classes e Metodos" , ExemploEnum.Executar},
                {"Struct - Classes e Metodos" , ExemploStruct.Executar},
                {"Struct vs Classes - Classes e Metodos" , StructVsClasse.Executar},
                {"Parametros por Referência - Classes e Metodos" , ParametrosPorReferencia.Executar},
                {"Parametros Padrao - Classes e Metodos" , ParametroPadrao.Executar},
                
                //Coleções
                
                {"Array - Coleções" , Colecoes.Array.Executar},
                {"List - Coleções" , Colecoes.List.Executar},
                {"ArrayList - Coleções" , Colecoes.ArrayList.Executar},
                
                //Orientação a Objetos
                
                {"Herança - Orientação a Objetos" , Heranca.Executar},
                {"Encapsulamento - Orientação a Objetos" , Encapsulamento.Executar},
                                
                
                
                
            });

            central.SelecionarEExecutar();
        }
    }
}
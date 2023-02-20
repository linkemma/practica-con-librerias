using Delegados;
using HerramientaRedimencionarImagenes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OCRTesseract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using static Delegados.DelegadosHdeleon;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //EjemploDelegates del1 = new EjemploDelegates();
            //del1.EjemploDelegado();
            //del1.EjemploAction();
            //del1.EjemploFunc();

            //SuscriptorCalculadora calculadora = new SuscriptorCalculadora(3, 2);
            //calculadora.OperacionSuma();
            //calculadora.OperacionResta();


            ////HDELEON FORMA 1  delegate
            //BuscaNumeroMayor fn1 = Buscar;
            //Console.WriteLine(fn1(new List<int> { 2, 5, 3, 5, 2, 99, 777 }));

            ////HDELEON FORMA 2  delegate
            //BuscaNumeroMayor fn2 = delegate (List<int> Lista)
            //{
            //    return Lista.OrderByDescending(d => d).First();
            //};
            //Console.WriteLine(fn2(new List<int> { 2, 5, 3, 444}));

            ////HDELEON FORMA 3  delegate

            //BuscaNumeroMayor fn3 = f => f.OrderByDescending(d => d).First();
            //Console.WriteLine(fn3(new List<int> { 1, 3, 5, 7, 22 }));

            ////// Convertir  imagen de un texto a texto
            //string pathImage = @"C:\Users\AMILCAR\source\repos\Delegados\OCRTesseract\image\espanol.jpg";
            //OCR Hoja = new OCR();
            //Console.WriteLine(Hoja.Constructor12(pathImage));

            string path1 = @"C:\Users\AMILCAR\source\repos\Delegados\HerramientaRedimencionarImagenes\img\a.jpg";
            Magick Imagen = new Magick();
            Imagen.MinimizaImagen(path1);
        }
    }
}

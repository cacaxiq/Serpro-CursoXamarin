// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace SerproShared.iOS
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton adicionarPessoa { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton listaPessoas { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txt_ativo { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txt_cpf { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txt_dataNascimento { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txt_nome { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txt_ocupacao { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txt_qtdadefilhos { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txt_sexo { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (adicionarPessoa != null) {
                adicionarPessoa.Dispose ();
                adicionarPessoa = null;
            }

            if (listaPessoas != null) {
                listaPessoas.Dispose ();
                listaPessoas = null;
            }

            if (txt_ativo != null) {
                txt_ativo.Dispose ();
                txt_ativo = null;
            }

            if (txt_cpf != null) {
                txt_cpf.Dispose ();
                txt_cpf = null;
            }

            if (txt_dataNascimento != null) {
                txt_dataNascimento.Dispose ();
                txt_dataNascimento = null;
            }

            if (txt_nome != null) {
                txt_nome.Dispose ();
                txt_nome = null;
            }

            if (txt_ocupacao != null) {
                txt_ocupacao.Dispose ();
                txt_ocupacao = null;
            }

            if (txt_qtdadefilhos != null) {
                txt_qtdadefilhos.Dispose ();
                txt_qtdadefilhos = null;
            }

            if (txt_sexo != null) {
                txt_sexo.Dispose ();
                txt_sexo = null;
            }
        }
    }
}
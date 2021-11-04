// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function adicionarUsuario() {
    var usuario = {};
    usuario.Login = $('#usuarioCadastro').val();
    usuario.Senha = $('#senhaCadastro').val();

    window.$.ajax({
        url: "/cadastrar-usuario",
        type: 'POST',
        datatype: 'json',
        data: {
            usuario
        },
        error: function (response) {
            alert(response.responseText);
        },
        success: function (response) {
            alert(response.responseText);
        }
    });
}

function fazerLogin() {
    var usuario = {};
    usuario.Login = $('#usuarioLogin').val();
    usuario.Senha = $('#senhaLogin').val();

    window.$.ajax({
        url: "/login",
        type: 'POST',
        datatype: 'json',
        data: {
            usuario
        },
        error: function (response) {
            alert(response.responseText);
        },
        success: function (response) {
            alert(response.responseText);
        }
    });
}
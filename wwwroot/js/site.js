// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


showNotaForm.addEventListener('click', closeFormEvent );
closeForm.addEventListener('click', closeFormEvent )

function closeFormEvent(e){
    e.preventDefault();
    notaForm.classList.toggle("showForm");
}
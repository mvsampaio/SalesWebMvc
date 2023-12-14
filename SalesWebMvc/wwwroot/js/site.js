// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
document.addEventListener('DOMContentLoaded', function () {
    var button = document.getElementById('filter-button');

    button.addEventListener('click', function (event) {
        const minDate = document.getElementById('minDate');
        const maxDate = document.getElementById('maxDate');
        const messageError = document.getElementById('alert-data-filter');

        if (minDate.value > maxDate.value) {
            event.preventDefault();
            messageError.classList.remove('visually-hidden');
        } else {
            messageError.classList.add('visually-hidden');
        }
    });
});   





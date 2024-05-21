// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
document.addEventListener("DOMContentLoaded", function () {
    // Voor cirkeldiagrammen
    const charts = document.querySelectorAll('.circle-chart');

    charts.forEach(chart => {
        const percent = chart.dataset.percent;
        const angle = (percent / 100) * 360;
        chart.style.background = `conic-gradient(
            #4caf50 0% ${angle}deg,
            #d3d3d3 ${angle}deg 360deg
        )`;

        const percentageElement = chart.querySelector('.percentage');
        if (percentageElement) {
            percentageElement.textContent = `${percent}%`;
        }
    });

    // Voor de voortgangsbalk
    const progressBar = document.querySelector('.progress-bar');

    const percentage = progressBar.dataset.percentage;
    progressBar.style.width = `${percentage}%`;
});
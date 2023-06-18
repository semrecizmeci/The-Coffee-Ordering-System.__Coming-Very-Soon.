var menuContainer = document.getElementById("menuContainer");
var menuBtns = document.querySelectorAll(".menu-btn");
let counter = document.querySelector(".counter");
let toplam = 0;

menuBtns.forEach(function (menuBtn) {
    menuBtn.addEventListener("click", function () {
        menuContainer.classList.add("open");
        toplam++;
        counter.textContent = `${toplam}`;
    });
});


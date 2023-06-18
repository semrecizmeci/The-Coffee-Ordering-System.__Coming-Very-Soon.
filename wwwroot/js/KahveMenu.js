"use strick";
let Siparis_ver = document.querySelector(".Siparis_ver");
let Sepete_git = document.querySelector(".Sepete_git");
let toplam = 0;

Siparis_ver.addEventListener("click", function () {
    toplam++;
    Sepete_git.textContent = `Sepete_Git :(${toplam})`;
});

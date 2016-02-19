// site.js
var ele = document.getElementById("UserName");
ele.innerHTML = "Avnit Bambah";

var main = document.getElementById("main");
main.onmouseenter = function () {
    main.style = "background-color: #888;";
};
main.onmouseleave = function () {
    main.style = "background-color: #782;";
};

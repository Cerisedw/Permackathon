let nameSpan = document.querySelector("#hardusernamecopy");
let dropdownEl = document.querySelector("#deleteMe");
nameSpan.innerText = "";
if(localStorage.getItem("user")){
    nameSpan.innerText = localStorage.getItem("user");
}
else {
    nameSpan.innerHTML = "";

}

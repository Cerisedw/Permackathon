
let welcomeDiv = document.getElementById("welcomeDiv");
let usernameSpan = document.getElementById("username");
let deleteMe= document.getElementById('deleteMe');
if(localStorage.getItem('user')){
    welcomeDiv.innerHTML = "<h2> Bienvenue, " + localStorage.getItem('user') + " !";
    usernameSpan.innerText = localStorage.getItem('user');
    

}
else {
    deleteMe.style.display = 'none';
}

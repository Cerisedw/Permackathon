var login = document.getElementById('exampleInputEmail');
function getRandomInt(max) {
    return Math.floor(Math.random() * Math.floor(max));
  }
var arrayName = ["Camcam", "Gauthier", "Cerise", "Nathan", "Marie", "Harry Potter", "Draco Malfoy","Jane Eyre", "Captain Toad", "Toad Kinopio", "Toad"];
var choice = getRandomInt(arrayName.length-1);
localStorage.setItem('user', arrayName[choice]);

// import axios from '../node_modules/axios';

// création card tache 

// let row   = document.querySelector('#items');

// for (let i = 0; i < myArray.length; i++ ) {

//     // récupération des différentes données à implanter ----------------------

//     let titreTache      = myArray[i].nom;
//     let nomEntreprise   = myArray[i].entreprise.nom;

//     // création des éléments pour l'html. Ils sont placés dans la boucle pour se multiplier 20x -------------------------------------------



//     let col              = document.createElement('div');
//     col.className='col-lg-4 col-md-6 mb-4';

//     let item              = document.createElement('div');
//     item.className='card h-100 task-item';

//     let cardBody = document.createElement('div');
//     cardBody.className = 'card-body';

//     let name        = document.createElement('h2');
//     name.className='card-title';



//     // implantation des différents éléments créés (pour le moment "flottés") dans l'html. De nouveau dans la boucle 20x.-----------------------------


//     col.appendChild(item);

//     cardBody.textContent = titreTache + ' ' + nomEntreprise;

//     item.appendChild(cardBody);


//     row.appendChild(col);

// axios.get('http://192.168.0.100:84/api/Tache/getall').then((res) => res.data).then((data) => console.log(data));

document.addEventListener('DOMContentLoaded', function(){
    let request = new XMLHttpRequest();
    let requestURL = 'http://192.168.0.100:84/api/Tache/getall';
    
    let toDo = document.querySelector("#todo");
    let doing = document.querySelector("#doing");
    let done = document.querySelector("#done");

    let date = moment().format('MMMM Do YYYY, h:mm:ss a');
    console.log(date);
    
    
    request.addEventListener('readystatechange', function(event){
        if (event.currentTarget.readyState == 4 && event.currentTarget.status == 200) {
            
            // la letiable prend les info sur l'API --------------------------------
            
            
            let permaDatabaseJSON = JSON.parse(event.currentTarget.responseText);
            let nombre = permaDatabaseJSON.length;
            

            for (let i = 0; i < nombre; i++ ) {
                
                // récupération des différentes données à implanter ----------------------
                
                let titreTache      = permaDatabaseJSON[i].nom;
                let nomEntreprise   = permaDatabaseJSON[i].entreprise.nom;
                let myId = permaDatabaseJSON[i].id;
                
                // création des éléments pour l'html. Ils sont placés dans la boucle pour se multiplier 20x -------------------------------------------
                
                
                
                let item              = document.createElement('div');
                item.className='card task-item';
                
                let cardBody = document.createElement('div');
                cardBody.className = 'card-body test';
                
                let name        = document.createElement('h2');
                name.className='card-title';
                
                let btnParticipant = document.createElement('button');
                btnParticipant.className="btn btn-primary btn-sm"
                btnParticipant.setAttribute('data-index', myId);
                btnParticipant.innerHTML="<i class='fas fa-plus text-white'></i>";
                btnParticipant.addEventListener('click', (event)=>{console.log(event.target.parentNode.dataset.index)});
                
                // implantation des différents éléments créés (pour le moment "flottés") dans l'html. De nouveau dans la boucle 20x.-----------------------------
                
                cardBody.textContent = titreTache + ' - ' + nomEntreprise;

                item.appendChild(cardBody);
                console.log(doing);
                
            
                if (permaDatabaseJSON[i].statut === 'En attente'){
                    cardBody.appendChild(btnParticipant);
                    toDo.appendChild(item);
                } 
                if (permaDatabaseJSON[i].statut === 'En cours'){
                    doing.appendChild(item);
                } 
                if (permaDatabaseJSON[i].statut === 'Fini'){
                    done.appendChild(item);
                } 
            }
        }
    })
    request.open('GET', requestURL, true);
    request.send();
    
    
    
});
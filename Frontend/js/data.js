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
                
                let btnParticipantContainer = document.createElement('div');
                btnParticipantContainer.className = " col-3 text-right";

                let btnParticipant = document.createElement('button');
                btnParticipant.setAttribute('type', 'button');
                btnParticipant.className="text-right btn btn-primary btn-sm";
                btnParticipant.setAttribute('data-toggle', 'modal');
                btnParticipant.setAttribute('data-target', '#modal'+myId);
                // btnParticipant.setAttribute('data-index', myId);

                btnParticipant.innerHTML="<i class='fas fa-plus text-white'></i>";

                let modalContainer = document.createElement('div');
                modalContainer.className="modal fade";
                modalContainer.setAttribute("id", 'modal'+myId);
                modalContainer.setAttribute("tabindex", "-1");
                modalContainer.setAttribute("role", "dialog");
                modalContainer.setAttribute("aria-ladelledby", "addParticipant");
                modalContainer.setAttribute("aria-hidden", "true");
                

                modalContainer.innerHTML = `
                <div class="modal-dialog" role="document">
                  <div class="modal-content">
                    <div class="modal-header">
                      <h5 class="modal-title" id="exampleModalLabel">Ajouter un participant à la tâche ${titreTache}</h5>
                      <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                      </button>
                    </div>
                    <div class="modal-body">
                    <form method="POST" action="http://192.168.0.100:84/api/tache/">
                    <div class="form-group">
                      <label for="prenomParticipant">Titre de la tâche</label>
                      <input type="text" class="form-control" name="Prenom" id="prenomParticipant" aria-describedby="tacheName" placeholder="Prénom du participant">
                    </div>
                    <div class="form-group">
                      <label for="nomParticipant">Description</label>
                      <input type="text" class="form-control" name="Nom" id="nomParticipant" placeholder="Nom du participant">
                    </div>
                    <div class="modal-footer">
                      <button type="button" class="btn btn-secondary" data-dismiss="modal">Fermer</button>
                      <button type="submit" class="btn btn-primary">Ajouter</button>
                    </div>
                  </form>
                    </div>
                  </div>
                </div>`;
                
                
                // implantation des différents éléments créés (pour le moment "flottés") dans l'html. De nouveau dans la boucle 20x.-----------------------------
                
                cardBody.textContent = titreTache + ' - ' + nomEntreprise;
                item.appendChild(cardBody);
                console.log(doing);
                
                
            
                if (permaDatabaseJSON[i].statut === 'En attente'){
                    cardBody.appendChild(btnParticipant);
                    cardBody.appendChild(modalContainer);
                    toDo.appendChild(item);
                } 
                if (permaDatabaseJSON[i].statut === 'En cours'){
                    cardBody.appendChild(btnParticipantContainer);
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
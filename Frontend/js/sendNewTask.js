$(document).ready(function() {

	// process the form
	$('#btngo').on("click",function(event) {

     
    
		// get the form data
		// there are many ways to get this data using jQuery (you can use the class or id also)
		var formData = {
			'Nom' 				: $('input[name=Nom]').val(),
			'Decription' 			: $('input[name=Description]').val(),
      'Priorite' 	: $('select[name=Priorite]').val(),
      'DateDeadline' 	: $('input[name=DateDeadline]').val(),
      'Type' 	: $('select[name=Type]').val(),
      'entreprise' :  'Entreprise de Charleroi'
      
		}; 
		// process the form
		$.ajax({
      type 		: 'POST', // define the type of HTTP verb we want to use (POST for our form)
      contentType: 'application/json;',
			url 		: 'http://192.168.0.100:84/api/Tache', // the url where we want to POST
      data 		: JSON.stringify( formData ),
      // our data object
			dataType 	: 'json', // what type of data do we expect back from the server
      encode 		: true,
      Accept: 'application/json'

		})
			// using the done promise callback
			.done(function(data) {

				// log data to the console so we can see
				console.log(data); 

				// here we will handle errors and validation messages
				if ( ! data.success) {
					
					// handle errors for name ---------------
					if (data.errors.name) {
						$('#name-group').addClass('has-error'); // add the error class to show red input
						$('#name-group').append('<div class="help-block">' + data.errors.name + '</div>'); // add the actual error message under our input
					}

					// handle errors for email ---------------
					if (data.errors.email) {
						$('#email-group').addClass('has-error'); // add the error class to show red input
						$('#email-group').append('<div class="help-block">' + data.errors.email + '</div>'); // add the actual error message under our input
					}

					// handle errors for superhero alias ---------------
					if (data.errors.superheroAlias) {
						$('#superhero-group').addClass('has-error'); // add the error class to show red input
						$('#superhero-group').append('<div class="help-block">' + data.errors.superheroAlias + '</div>'); // add the actual error message under our input
					}

				} else {

					// ALL GOOD! just show the success message!
					$('form').append('<div class="alert alert-success">' + data.message + '</div>');

					// usually after form submission, you'll want to redirect
					// window.location = '/thank-you'; // redirect a user to another page

				}
			})

			// using the fail promise callback
			.fail(function(data) {

				// show any errors
				// best to remove for production
				console.log(data);
			});

		// stop the form from submitting the normal way and refreshing the page
		event.preventDefault();
	});

});
// magic.js
$(document).ready(function() {

	// process the form
	$('form').submit(function(event) {

		$('.form-group').removeClass('has-error'); // remove the error class
		$('.help-block').remove(); // remove the error text

		// get the form data
		// there are many ways to get this data using jQuery (you can use the class or id also)
		var formData = {
			'Prenom' 				: $('input[name=Prenom]').val(),
			'Nom' 			: $('input[name=Nom]').val(),
            'Email' 	: $('input[name=Email]').val(),
            'Password' 	: $('input[name=Password]').val(),
            'PasswordCheck' 	: $('input[name=PasswordCheck]').val(),
            'Poste' 	: $('input[name=Poste]').val(),
            'Role' 	: $('input[name=Role]').val(),
            'Image' 	: $('input[name=Image]').val(),
		};

		// process the form
		$.ajax({
			type 		: 'POST', // define the type of HTTP verb we want to use (POST for our form)
			url 		: 'http://192.168.0.100:84/api/utilisateur/register', // the url where we want to POST
			data 		: formData, // our data object
			dataType 	: 'json', // what type of data do we expect back from the server
			encode 		: true
		})
			// using the done promise callback
			.done(function(data) {

				// log data to the console so we can see
				console.log(data); 

				// here we will handle errors and validation messages
				if ( ! data.success) {
					
					// handle errors for name ---------------
					if (data.errors.Nom) {
						$('#name-group').addClass('has-error'); // add the error class to show red input
						$('#name-group').append('<div class="help-block">' + data.errors.Nom + '</div>'); // add the actual error message under our input
					}

					// handle errors for email ---------------
					if (data.errors.Email) {
						$('#email-group').addClass('has-error'); // add the error class to show red input
						$('#email-group').append('<div class="help-block">' + data.errors.Email + '</div>'); // add the actual error message under our input
					}
				

				} else {

					// ALL GOOD! just show the success message!
					$('form').append('<div class="alert alert-success">' + data.message + '</div>');

					// usually after form submission, you'll want to redirect
					window.location = '../login.html'; // redirect a user to another page

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
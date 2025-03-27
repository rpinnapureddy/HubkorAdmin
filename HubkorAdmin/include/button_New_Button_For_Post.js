Runner.buttonEvents["New_Button_For_Post"] = function( pageObj, proxy, pageid ) {
	//register a new button
	pageObj.buttonNames[ pageObj.buttonNames.length ] = 'New_Button_For_Post';
	
	if ( !pageObj.buttonEventBefore['New_Button_For_Post'] ) {
		pageObj.buttonEventBefore['New_Button_For_Post'] = function( params, ctrl, pageObj, proxy, pageid, rowData, row, submit ) {		
			var ajax = ctrl;

		}
	}
	
	if ( !pageObj.buttonEventAfter['New_Button_For_Post'] ) {
		pageObj.buttonEventAfter['New_Button_For_Post'] = function( result, ctrl, pageObj, proxy, pageid, rowData, row, params ) {
			var ajax = ctrl;

// Retrieve the result from the server
var message = result["txt"];

// Show a SweetAlert success message
swal("Success", message, "success");

		}
	}
	
	$('a[id="New_Button_For_Post"]').each( function() {
		if ( $(this).closest('.gridRowAdd').length ) {
			return;
		}
		
		this.id = "New_Button_For_Post" + "_" + Runner.genId();
		
		// create object
		var button_New_Button_For_Post = new Runner.form.Button({
			id: this.id ,
			btnName: "New_Button_For_Post"
		});
		
		// init
		button_New_Button_For_Post.init( {args: [ pageObj, proxy, pageid ]} );
	});
};


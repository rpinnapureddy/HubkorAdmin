Runner.buttonEvents["Post"] = function( pageObj, proxy, pageid ) {
	//register a new button
	pageObj.buttonNames[ pageObj.buttonNames.length ] = 'Post';
	
	if ( !pageObj.buttonEventBefore['Post'] ) {
		pageObj.buttonEventBefore['Post'] = function( params, ctrl, pageObj, proxy, pageid, rowData, row, submit ) {		
			var ajax = ctrl;

		}
	}
	
	if ( !pageObj.buttonEventAfter['Post'] ) {
		pageObj.buttonEventAfter['Post'] = function( result, ctrl, pageObj, proxy, pageid, rowData, row, params ) {
			var ajax = ctrl;
var message = result["txt"];

// Show an appropriate SweetAlert message
if (message.includes("Provision Email successfully sent.")) {
    // Success case
    swal("Success", message, "success");
} else {
    // Failure case
    swal("Error", message, "error");
}
		}
	}
	
	$('a[id="Post"]').each( function() {
		if ( $(this).closest('.gridRowAdd').length ) {
			return;
		}
		
		this.id = "Post" + "_" + Runner.genId();
		
		// create object
		var button_Post = new Runner.form.Button({
			id: this.id ,
			btnName: "Post"
		});
		
		// init
		button_Post.init( {args: [ pageObj, proxy, pageid ]} );
	});
};


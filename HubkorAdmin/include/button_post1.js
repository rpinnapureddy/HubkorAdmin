Runner.buttonEvents["post1"] = function( pageObj, proxy, pageid ) {
	//register a new button
	pageObj.buttonNames[ pageObj.buttonNames.length ] = 'post1';
	
	if ( !pageObj.buttonEventBefore['post1'] ) {
		pageObj.buttonEventBefore['post1'] = function( params, ctrl, pageObj, proxy, pageid, rowData, row, submit ) {		
			var ajax = ctrl;

		}
	}
	
	if ( !pageObj.buttonEventAfter['post1'] ) {
		pageObj.buttonEventAfter['post1'] = function( result, ctrl, pageObj, proxy, pageid, rowData, row, params ) {
			var ajax = ctrl;
var message = result["txt"];

// Show an appropriate SweetAlert message
if (message.includes("invoice Reposted successfully.")) {
    // Success case
    swal("Success", message, "success");
} else {
    // Failure case
    swal("Error", message, "error");
}
		}
	}
	
	$('a[id="post1"]').each( function() {
		if ( $(this).closest('.gridRowAdd').length ) {
			return;
		}
		
		this.id = "post1" + "_" + Runner.genId();
		
		// create object
		var button_post1 = new Runner.form.Button({
			id: this.id ,
			btnName: "post1"
		});
		
		// init
		button_post1.init( {args: [ pageObj, proxy, pageid ]} );
	});
};


Runner.buttonEvents["payload"] = function( pageObj, proxy, pageid ) {
	//register a new button
	pageObj.buttonNames[ pageObj.buttonNames.length ] = 'payload';
	
	if ( !pageObj.buttonEventBefore['payload'] ) {
		pageObj.buttonEventBefore['payload'] = function( params, ctrl, pageObj, proxy, pageid, rowData, row, submit ) {		
			var ajax = ctrl;

		}
	}
	
	if ( !pageObj.buttonEventAfter['payload'] ) {
		pageObj.buttonEventAfter['payload'] = function( result, ctrl, pageObj, proxy, pageid, rowData, row, params ) {
			var ajax = ctrl;
// Client After: Set the payload dynamically for each record
var buttons = document.getElementsByClassName('payload');  // Match the button's class

for (var i = 0; i < buttons.length; i++) {
    var button = buttons[i];

    // Get the payload value directly from the 'data-payload' attribute
    var payload = button.getAttribute('data-payload');  // Fetch the payload value for each row

    // Attach the click event listener
    button.addEventListener('click', function(event) {
        var payload = this.getAttribute('data-payload'); // Get the payload for this button
        showPayload(JSON.parse(payload));  // Display it in the modal (or however you want)
    });
}
		}
	}
	
	$('a[id="payload"]').each( function() {
		if ( $(this).closest('.gridRowAdd').length ) {
			return;
		}
		
		this.id = "payload" + "_" + Runner.genId();
		
		// create object
		var button_payload = new Runner.form.Button({
			id: this.id ,
			btnName: "payload"
		});
		
		// init
		button_payload.init( {args: [ pageObj, proxy, pageid ]} );
	});
};


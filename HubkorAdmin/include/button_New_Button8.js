Runner.buttonEvents["New_Button8"] = function( pageObj, proxy, pageid ) {
	//register a new button
	pageObj.buttonNames[ pageObj.buttonNames.length ] = 'New_Button8';
	
	if ( !pageObj.buttonEventBefore['New_Button8'] ) {
		pageObj.buttonEventBefore['New_Button8'] = function( params, ctrl, pageObj, proxy, pageid, rowData, row, submit ) {		
			var ajax = ctrl;

		}
	}
	
	if ( !pageObj.buttonEventAfter['New_Button8'] ) {
		pageObj.buttonEventAfter['New_Button8'] = function( result, ctrl, pageObj, proxy, pageid, rowData, row, params ) {
			var ajax = ctrl;
// Put your code here.
var message = result["txt"] + " !!!";
ajax.setMessage(message);

		}
	}
	
	$('a[id="New_Button8"]').each( function() {
		if ( $(this).closest('.gridRowAdd').length ) {
			return;
		}
		
		this.id = "New_Button8" + "_" + Runner.genId();
		
		// create object
		var button_New_Button8 = new Runner.form.Button({
			id: this.id ,
			btnName: "New_Button8"
		});
		
		// init
		button_New_Button8.init( {args: [ pageObj, proxy, pageid ]} );
	});
};


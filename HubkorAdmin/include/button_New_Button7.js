Runner.buttonEvents["New_Button7"] = function( pageObj, proxy, pageid ) {
	//register a new button
	pageObj.buttonNames[ pageObj.buttonNames.length ] = 'New_Button7';
	
	if ( !pageObj.buttonEventBefore['New_Button7'] ) {
		pageObj.buttonEventBefore['New_Button7'] = function( params, ctrl, pageObj, proxy, pageid, rowData, row, submit ) {		
			var ajax = ctrl;

		}
	}
	
	if ( !pageObj.buttonEventAfter['New_Button7'] ) {
		pageObj.buttonEventAfter['New_Button7'] = function( result, ctrl, pageObj, proxy, pageid, rowData, row, params ) {
			var ajax = ctrl;
var message = result["txt"];


 swal ("Success",  message, "success" );
		}
	}
	
	$('a[id="New_Button7"]').each( function() {
		if ( $(this).closest('.gridRowAdd').length ) {
			return;
		}
		
		this.id = "New_Button7" + "_" + Runner.genId();
		
		// create object
		var button_New_Button7 = new Runner.form.Button({
			id: this.id ,
			btnName: "New_Button7"
		});
		
		// init
		button_New_Button7.init( {args: [ pageObj, proxy, pageid ]} );
	});
};


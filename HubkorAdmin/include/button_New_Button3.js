Runner.buttonEvents["New_Button3"] = function( pageObj, proxy, pageid ) {
	//register a new button
	pageObj.buttonNames[ pageObj.buttonNames.length ] = 'New_Button3';
	
	if ( !pageObj.buttonEventBefore['New_Button3'] ) {
		pageObj.buttonEventBefore['New_Button3'] = function( params, ctrl, pageObj, proxy, pageid, rowData, row, submit ) {		
			var ajax = ctrl;

		}
	}
	
	if ( !pageObj.buttonEventAfter['New_Button3'] ) {
		pageObj.buttonEventAfter['New_Button3'] = function( result, ctrl, pageObj, proxy, pageid, rowData, row, params ) {
			var ajax = ctrl;
var message = result["txt"];


 swal ("Success",  message, "success" );
		}
	}
	
	$('a[id="New_Button3"]').each( function() {
		if ( $(this).closest('.gridRowAdd').length ) {
			return;
		}
		
		this.id = "New_Button3" + "_" + Runner.genId();
		
		// create object
		var button_New_Button3 = new Runner.form.Button({
			id: this.id ,
			btnName: "New_Button3"
		});
		
		// init
		button_New_Button3.init( {args: [ pageObj, proxy, pageid ]} );
	});
};



function inicio() {
	$("span.help-block").hide();
	$("#Bienvenida").modal();

	$("#btn-enviar").click(function () {
		if (validar() == false || validar2() == false || validar_calle() == false || validar_interior() == false || validar_exterior() == false || validar_colonia() == false || validar_cp() == false || validar_maps() == false || validar_uni() == false) 

			$('#campos_vacios').modal('show');
        		
		else {
			$('#confirmar').modal('show');
		}
	});

	$("#telefono1").keyup(validar);
	$("#telefono2").keyup(validar2);
	$("#calle").keyup(validar_calle);
	$("#interior").keyup(validar_interior);
	$("#exterior").keyup(validar_exterior);
	$("#colonia").keyup(validar_colonia);
	$("#cp").keyup(validar_cp);
	$("#maps").keyup(validar_maps);
	$("#IdUniversidad2").keyup(validar_uni);

	
}

function validar() {
	var valor = document.getElementById("telefono1").value;
	if (valor == null || valor.length == 0 || /^\s+$/.test(valor)) {
		$("#iconotexto").remove();
		$("#telefono1").parent().parent().attr("class", "form-group row has-error has-feedback");
		$("#telefono1").parent().children("span").text("Debe ingresar algun caracter").show();
		$("#telefono1").parent().append("<span id='iconotexto' class='glyphicon glyphicon-remove form-control-feedback'></span>");
		return false;
	}
	else if (valor.length >= 11 && valor.length <= 11) {
		$("#iconotexto").remove();
		$("#telefono1").parent().parent().attr("class", "form-group row has-error has-feedback");
		$("#telefono1").parent().children("span").text("Numero telefónico invalido").show();
		$("#telefono1").parent().append("<span id='iconotexto' class='glyphicon glyphicon-remove form-control-feedback'></span>");
		return false;
	}
	else if (isNaN(valor)) {
		$("#iconotexto").remove();
		$("#telefono1").parent().parent().attr("class", "form-group row has-error has-feedback");
		$("#telefono1").parent().children("span").text("Debe ingresar caracteres numericos").show();
		$("#telefono1").parent().append("<span id='iconotexto' class='glyphicon glyphicon-remove form-control-feedback'></span>");
		return false;
	}
	else {
		$("#iconotexto").remove();
		$("#telefono1").parent().parent().attr("class", "form-group row has-success ");
		$("#telefono1").parent().children("span").text("").hide();
		$("#telefono1").parent().append("<span id='iconotexto' class='glyphicon glyphicon-ok form-control-feedback'></span>");
		return true;
	}
}


function validar2() {
	var valor = document.getElementById("telefono2").value;
	if (valor == null || valor.length == 0 || /^\s+$/.test(valor)) {
		$("#iconotexto1").remove();
		$("#telefono2").parent().parent().attr("class", "form-group row has-error has-feedback");
		$("#telefono2").parent().children("span").text("Debe ingresar algun caracter").show();
		$("#telefono2").parent().append("<span id='iconotexto1' class='glyphicon glyphicon-remove form-control-feedback '></span>");
		return false;
	}

	else if (isNaN(valor)) {
		$("#iconotexto1").remove();
		$("#telefono2").parent().parent().attr("class", "form-group row has-error has-feedback");
		$("#telefono2").parent().children("span").text("Debe ingresar caracteres numericos").show();
		$("#telefono2").parent().append("<span id='iconotexto1' class='glyphicon glyphicon-remove form-control-feedback'></span>");
		return false;
	}
	else if (valor.length >= 11 && valor.length <= 11) {
		$("#iconotexto1").remove();
		$("#telefono2").parent().parent().attr("class", "form-group row has-error has-feedback");
		$("#telefono2").parent().children("span").text("Numero telefónico invalido").show();
		$("#telefono2").parent().append("<span id='iconotexto1' class='glyphicon glyphicon-remove form-control-feedback'></span>");
		return false;
	}
	else {
		$("#iconotexto1").remove();
		$("#telefono2").parent().parent().attr("class", "form-group row has-success has-feedback");
		$("#telefono2").parent().children("span").text("").hide();
		$("#telefono2").parent().append("<span id='iconotexto1' class='glyphicon glyphicon-ok form-control-feedback'></span>");
		return true;
	}
}


function validar_calle() {
	var valor = document.getElementById("calle").value;
	if (valor == null || valor.length == 0 || /^\s+$/.test(valor)) {
		$("#iconotexto3").remove();
		$("#calle").parent().parent().attr("class", "form-group row has-error has-feedback");
		$("#calle").parent().children("span").text("Debe ingresar algun caracter").show();
		$("#calle").parent().append("<span id='iconotexto3' class='glyphicon glyphicon-remove form-control-feedback '></span>");
		return false;
	}else {
		$("#iconotexto3").remove();
		$("#calle").parent().parent().attr("class", "form-group row has-success has-feedback");
		$("#calle").parent().children("span").text("").hide();
		$("#calle").parent().append("<span id='iconotexto3' class='glyphicon glyphicon-ok form-control-feedback'></span>");
		return true;
	}
}

function validar_interior() {
	var valor = document.getElementById("interior").value;
	if (valor == null || valor.length == 0 || /^\s+$/.test(valor)) {
		$("#iconotexto4").remove();
		$("#interior").parent().parent().attr("class", "form-group row has-error has-feedback");
		$("#interior").parent().children("span").text("Debe ingresar algun caracter").show();
		$("#interior").parent().append("<span id='iconotexto4' class='glyphicon glyphicon-remove form-control-feedback '></span>");
		return false;
	} else if (isNaN(valor)) {
		$("#iconotexto4").remove();
		$("#interior").parent().parent().attr("class", "form-group row has-error has-feedback");
		$("#interior").parent().children("span").text("Debe ingresar caracteres numericos").show();
		$("#interior").parent().append("<span id='iconotexto4' class='glyphicon glyphicon-remove form-control-feedback'></span>");
		return false;
	}else {
		$("#iconotexto4").remove();
		$("#interior").parent().parent().attr("class", "form-group row has-success has-feedback");
		$("#interior").parent().children("span").text("").hide();
		$("#interior").parent().append("<span id='iconotexto4' class='glyphicon glyphicon-ok form-control-feedback'></span>");
		return true;
	}
}

function validar_exterior() {
	var valor = document.getElementById("exterior").value;
	if (valor == null || valor.length == 0 || /^\s+$/.test(valor)) {
		$("#iconotexto5").remove();
		$("#exterior").parent().parent().attr("class", "form-group row has-error has-feedback");
		$("#exterior").parent().children("span").text("Debe ingresar algun caracter").show();
		$("#exterior").parent().append("<span id='iconotexto5' class='glyphicon glyphicon-remove form-control-feedback '></span>");
		return false;
	} else if (isNaN(valor)) {
		$("#iconotexto5").remove();
		$("#exterior").parent().parent().attr("class", "form-group row has-error has-feedback");
		$("#exterior").parent().children("span").text("Debe ingresar caracteres numericos").show();
		$("#exterior").parent().append("<span id='iconotexto5' class='glyphicon glyphicon-remove form-control-feedback'></span>");
		return false;
	} else {
		$("#iconotexto5").remove();
		$("#exterior").parent().parent().attr("class", "form-group row has-success has-feedback");
		$("#exterior").parent().children("span").text("").hide();
		$("#exterior").parent().append("<span id='iconotexto5' class='glyphicon glyphicon-ok form-control-feedback'></span>");
		return true;
	}
}

function validar_colonia() {
	var valor = document.getElementById("colonia").value;
	if (valor == null || valor.length == 0 || /^\s+$/.test(valor)) {
		$("#iconotexto6").remove();
		$("#colonia").parent().parent().attr("class", "form-group row has-error has-feedback");
		$("#colonia").parent().children("span").text("Debe ingresar algun caracter").show();
		$("#colonia").parent().append("<span id='iconotexto6' class='glyphicon glyphicon-remove form-control-feedback '></span>");
		return false;
	} else {
		$("#iconotexto6").remove();
		$("#colonia").parent().parent().attr("class", "form-group row has-success has-feedback");
		$("#colonia").parent().children("span").text("").hide();
		$("#colonia").parent().append("<span id='iconotexto6' class='glyphicon glyphicon-ok form-control-feedback'></span>");
		return true;
	}
}

function validar_cp() {
	var valor = document.getElementById("cp").value;
	if (valor == null || valor.length == 0 || /^\s+$/.test(valor)) {
		$("#iconotexto7").remove();
		$("#cp").parent().parent().attr("class", "form-group row has-error has-feedback");
		$("#cp").parent().children("span").text("Debe ingresar algun caracter").show();
		$("#cp").parent().append("<span id='iconotexto7' class='glyphicon glyphicon-remove form-control-feedback '></span>");
		return false;
	} else if (isNaN(valor)) {
		$("#iconotexto7").remove();
		$("#cp").parent().parent().attr("class", "form-group row has-error has-feedback");
		$("#cp").parent().children("span").text("Debe ingresar caracteres numericos").show();
		$("#cp").parent().append("<span id='iconotexto7' class='glyphicon glyphicon-remove form-control-feedback'></span>");
		return false;
	} else {
		$("#iconotexto7").remove();
		$("#cp").parent().parent().attr("class", "form-group row has-success has-feedback");
		$("#cp").parent().children("span").text("").hide();
		$("#cp").parent().append("<span id='iconotexto7' class='glyphicon glyphicon-ok form-control-feedback'></span>");
		return true;
	}
}

function validar_maps() {
	var valor = document.getElementById("maps").value;
	if (valor == null || valor.length == 0 || /^\s+$/.test(valor)) {
		$("#iconotexto8").remove();
		$("#maps").parent().parent().attr("class", "form-group row has-error has-feedback");
		$("#maps").parent().children("span").text("Debe ingresar algun caracter").show();
		$("#maps").parent().append("<span id='iconotexto8' class='glyphicon glyphicon-remove form-control-feedback '></span>");
		return false;
	} else {
		$("#iconotexto8").remove();
		$("#maps").parent().parent().attr("class", "form-group row has-success has-feedback");
		$("#maps").parent().children("span").text("").hide();
		$("#maps").parent().append("<span id='iconotexto8' class='glyphicon glyphicon-ok form-control-feedback'></span>");
		return true;
	}
}

function validar_uni() {
	var valor = document.getElementById("IdUniversidad2").value;
	if (valor == null || valor.length == 0 ) {
		$("#iconotexto9").remove();
		$("#IdUniversidad2").parent().parent().attr("class", "form-group row has-error has-feedback");
		$("#IdUniversidad2").parent().children("span").text("Debe de seleccionar una Universidad").show();
		$("#IdUniversidad2").parent().append("<span id='iconotexto8' class='glyphicon glyphicon-remove form-control-feedback '></span>");
		return false;
	} else {
		$("#iconotexto9").remove();
		$("#IdUniversidad2").parent().parent().attr("class", "form-group row has-success has-feedback");
		$("#IdUniversidad2").parent().children("span").text("").hide();
		$("#IdUniversidad2").parent().append("<span id='iconotexto8' class='glyphicon glyphicon-ok form-control-feedback'></span>");
		return true;
	}

}


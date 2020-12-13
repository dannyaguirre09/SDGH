let cboIndicesPrincipales = document.getElementById('cboIndicesPrincipales');
let cbo = document.getElementById("cboIndiceSecundario");
let textAreaComentario = document.getElementById('textAreaComentario');
let idDef = document.getElementById('idDef');
let idPre = document.getElementById('idPre');
cboIndicesPrincipales.addEventListener('change', obtenerIndicesSecundarios);
cbo.addEventListener('change', obtenerDiagnostico);
obtenerIndicesSecundarios();

$(document).ready(function () {
	$('.alert').fadeIn();
	setTimeout(function () {
		$(".alert").fadeOut();
	}, 5000);
});

function obtenerIndicesSecundarios() {
	var url = '/Diagnostico/ObtenerListaIndicesSecundarios?id=' + cboIndicesPrincipales.value;
	$.get(url, function (response) {
		if (response.estado) {
			cbo.innerHTML = "";
			let opt = document.createElement("option");
			opt.appendChild(document.createTextNode("Seleccione una opción"));
			opt.value = "";
			cbo.appendChild(opt);
			response.lista.forEach(function (element) {
				opt = document.createElement("option");
				opt.appendChild(document.createTextNode(element.INSDESCRIPCION));
				opt.value = element.INSCODIGOI;
				cbo.appendChild(opt);
				cbo.setAttribute('required', 'required');
			});
		} else {			
			let mensajeError = document.getElementById('mensajeError');
			mensajeError.hidden = false;
			mensajeError.innerText = response.mensaje;			
		}
	});

}

function obtenerDiagnostico() {
	let codHist = document.getElementById('codHist');
	var url = '/Diagnostico/ObtenerDiagnostico?idIndice=' + cbo.value + '&codHist='+ codHist.value;
	$.get(url, function (response) {
		if (response.estado) {
			if (response.diagnostico.DGNCODIGOI === 0) {
				let DGNCODIGOI = document.getElementById('DGNCODIGOI');
				DGNCODIGOI.value = "0";
				textAreaComentario.value = "";
				idPre.checked = false;
				idDef.checked = false;
			} else {
				let DGNCODIGOI = document.getElementById('DGNCODIGOI');
				DGNCODIGOI.value = response.diagnostico.DGNCODIGOI;
				textAreaComentario.value = response.diagnostico.DGNOBSERVACION;
				if (response.diagnostico.DGNTIPO.trim() === 'PRE')
					idPre.checked = "checked";
				else
					idDef.checked = "checked";
			}
		} else {
			let mensajeError = document.getElementById('mensajeError');
			mensajeError.hidden = false;
			mensajeError.innerText = response.mensaje;
		}
	});
}
let TPFCODIGOI = document.getElementById('TPFCODIGOI');
let codHist = document.getElementById('codHist');
let textAreaComentario = document.getElementById('textAreaComentario');
TPFCODIGOI.addEventListener('change', obtenerExamenFisico);
obtenerExamenFisico();

$(document).ready(function () {
	$('.alert').fadeIn();
	setTimeout(function () {
		$(".alert").fadeOut();
	}, 5000);
});

function obtenerExamenFisico() {
	textAreaComentario.value = ''
	var url = '/ExamenFisico/ObtenerExamenFisico?TPFCODIGOI=' + TPFCODIGOI.value + '&HSCCODIGOI=' + codHist.value;
	$.get(url, function (response) {
		if (response.estado) {		
			if (response.obj != null) {				
				textAreaComentario.value = ''
				textAreaComentario.value = response.obj.EXFDESCRIPCION;
				textAreaComentario.setAttribute('onblur', "insertarComentario(" + response.obj.EXFCODIGOI + ")")
			} else {
				textAreaComentario.setAttribute('onblur', "insertarComentario(0)")
			}

		} else {
			textAreaComentario.innerText = '';
			let mensajeError = document.getElementById('mensajeError');
			mensajeError.hidden = false;
			mensajeError.innerText = response.mensaje;
		}
	});
}

async function insertarComentario(EXFCODIGOI) {
	await $.post('/ExamenFisico/InsertarExamenFisico', {
		EXFCODIGOI: EXFCODIGOI,
		TPFCODIGOI: TPFCODIGOI.value,
		HSCCODIGOI: codHist.value,
		EXFDESCRIPCION: textAreaComentario.value,
	}, function (data, status) {
			if (status) {
				if (!data.estado) {
					textAreaComentario.innerText = '';
					let mensajeError = document.getElementById('mensajeError');
					mensajeError.hidden = false;
					mensajeError.innerText = response.mensaje;
				}

			} else {
				textAreaComentario.innerText = '';
				let mensajeError = document.getElementById('mensajeError');
				mensajeError.hidden = false;
				mensajeError.innerText = 'No ha sido posible conectarse al servidor';
			}		
			
			obtenerExamenFisico();
	});

}
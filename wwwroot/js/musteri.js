function OnUlkeDegistir() {
    var seciliUlkeId = $('#UlkeId').val();
    $("#SehirId").empty();

    $.ajax({
        type: "GET",
        url: "https://localhost:7129/api/Musteri/SehirGetir?ulkeId=" + seciliUlkeId,
        success: function (data) {
            $.each(data, function (val, sehir) {
                $('#SehirId').append(
                    $('<option></option>').val(sehir.id).html(sehir.adi)
                );
            });
        },
        error: function (req, status, error) {
            console.log(msg);
        }
    });
}

function MusteriKaydet() {
    var musteri = {
        Adi: $('#Adi').val(),
        Adresi: $('#Adresi').val(),
        SehirId: $('#SehirId').val()
    };

    $.ajax({
        type: "POST",
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        url: "https://localhost:7129/api/Musteri/Kaydet",
        data: JSON.stringify(musteri),
        dataType: 'json',
        success: function (data) {
            window.location = "/index.html"
        },
        error: function (req, status, error) {

        }
    });
}

function MusteriListele() {
    $.ajax({
        type: "GET",
        url: "https://localhost:7129/api/Musteri/Listele",
        success: function (data) {
            $.each(data, function (val, musteri) {
                var row = `<tr>
				    <td>` + musteri.adi + `</td>
				    <td>` + musteri.adresi + `</td>
				    <td>` + musteri.sehir.ulke.adi + `</td>
				    <td>` + musteri.sehir.adi + `</td>
			    </tr>`;

                $('#tblMusteri > tbody:last-child').append(row);
            });
        },
        error: function (req, status, error) {
            //console.log(msg);
        }
    });
}
function UrunListele() {
    $.ajax({
        type: "GET",
        url: "https://localhost:7129/api/Siparis/UrunleriGetir",
        success: function (data) {
            $.each(data, function (val, urun) {
                $('#UrunId').append(
                    $('<option></option>').val(urun.id).html(urun.adi)
                );
            });
        },
        error: function (req, status, error) {
            console.log(msg);
        }
    });
}

function MusteriListele() {
    $.ajax({
        type: "GET",
        url: "https://localhost:7129/api/Musteri/Listele",
        success: function (data) {
            $.each(data, function (val, musteri) {
                $('#MusteriId').append(
                    $('<option></option>').val(musteri.id).html(musteri.adi)
                );
            });
        },
        error: function (req, status, error) {
            console.log(msg);
        }
    });
}

function UrunFiyatiGetir() {
    var seciliUrunId = $('#UrunId').val();

    $.ajax({
        type: "GET",
        url: "https://localhost:7129/api/siparis/UrunFiyatiGetir?id=" + seciliUrunId,
        success: function (data) {
            var miktar = $('#Adet').val();
            var tutar = miktar * data;

            $('#Tutar').val(tutar);
        },
        error: function (req, status, error) {
            console.log(msg);
        }
    });
}

function SiparisKaydet() {
    var siparis = {
        MusteriId: $('#MusteriId').val(),
        No: $('#No').val(),
        Tarih: $('#Tarih').val(),
        Urunler:
        [
            {
                UrunId: $('#UrunId').val(),
                Adet: $('#Adet').val(),
                Tutar: $('#Tutar').val()
            } 
        ]
    };

    $.ajax({
        type: "POST",
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        url: "https://localhost:7129/api/Siparis/Kaydet",
        data: JSON.stringify(siparis),
        dataType: 'json',
        success: function (data) {
            window.location = "/siparis.html"
        },
        error: function (req, status, error) {
            alert("Lütfen zorunlu alanları doldurun");
        }
    });
}

function SiparisListele() {
    $.ajax({
        type: "GET",
        url: "https://localhost:7129/api/Siparis/Listele",
        success: function (data) {
            $.each(data, function (val, siparis) {
                var row = `<tr>
				    <td>` + siparis.no + `</td>
				    <td>` + siparis.musteri.adi + `</td>
				    <td>` + siparis.tarih + `</td>
				    <td>` + siparis.tutar + `</td>
			    </tr>`;

                $('#tblSiparis > tbody:last-child').append(row);
            });
        },
        error: function (req, status, error) {
            //console.log(msg);
        }
    });
}
$(function () {
    $(document).on("click",".load", function (e) {
        e.preventDefault();
        let url = $(".load").attr("href")
        $.ajax({
            url: url,
            method: "GET",
            dataType: "Json",
            success: function (response) {
/*                console.log(response);*/
                let a = "";
                for (let i = 0; i < response.length; i++) {
                    a += `<div class="col-lg-4 col-md-6 d-flex align-items-stretch">
                        <div class="member">
                            <img src="/assets/img/trainers/${response[i].img}" class="img-fluid" alt="">
                                <div class="member-content">
                                    <h4>${response[i].name} ${response[i].surname}</h4>
                                    <span>${response[i].category.name}</span>
                                    <p>
                                        ${response[i].info}
                                    </p>
                                    <div class="social">
                                        <a asp-><i class="${response[i].twitter}"></i></a>
                                        <a href=""><i class="${response[i].facebook}"></i></a>
                                        <a href=""><i class="${response[i].instagram}"></i></a>
                                        <a href=""><i class="${response[i].linkedIn}"></i></a>
                                    </div>
                                </div>
                        </div>
                        </div>`
                }
                $(".trainerrow").append(a);
            }
        })
    })
})
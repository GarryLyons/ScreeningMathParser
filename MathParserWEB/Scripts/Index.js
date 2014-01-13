$(function () {
    $('#Calculate').click(function () {
        $.ajax({
            dataType: "json",
            url: "MathParser/calc?Value=" + $('#ParseMe').val(),
            success: function (data) {

                if (data.IsValid) {
                    $('#Answerlabel').html('Answer');
                    $('#AnswerResult').html(data.Answer);
                }
                else
                {
                    $('#Answerlabel').html('Error');
                    $('#AnswerResult').html(data.Description);
                }
            }

        });

    });
})
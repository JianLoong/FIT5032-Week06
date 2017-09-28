// Please remember that javascript is a functional language.
$(document).ready(function () {
    // Here I made an ID field called date-input (in the view), however you do not need to do this.
    // https://stackoverflow.com/questions/1328025/jquery-ui-datepicker-change-date-format
    $("#date-input").datepicker(
          { dateFormat: 'yy-mm-dd' }
    );


    // Here, I would select the child from the tbody. There are many ways to do this.
    $('tbody > tr').hover(
       function () { $(this).addClass('dataHover') },
       function () { $(this).removeClass('dataHover') }
    )

    // Pay attention to the uppercase and lowercase.
    $("table").DataTable();

    // Alternate row highlight via jquery. There are multiple ways to do this.
    $("tbody > tr:even").css("background-color", "#F0F8FF");

});


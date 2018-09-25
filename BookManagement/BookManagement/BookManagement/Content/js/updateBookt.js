$('.preview-wrap div:nth-child(2)').click(function () {
    console.log('HI');
    $(this).closest('div.book-item-figure').children('.modal').modal({ show: true });
})
var productController=function()
{
    this.initialize = function () {
        loadDate();
    }
    function registerEvents() {

    }
    function loadDate() {
        var template = $('#table-template').html();
        var render = "";
        $.ajax({
            type: 'GET',
            url: '/admin/product/GetAll',
            dataType: 'JSON',
            success: function (res) {
                $.each(res, function (i, item) {
                    render += Mustache.render(template, {
                        Id: item.Id,
                        Name: item.Name,
                        Image: item.Image == null ? '<img src="/admin-side/images/user.png" width=25' : '<img src="' + item.Image + '" width=25 />',
                        CategoryName: item.ProductCategory.Name,
                        Price: structures.formatNumber(item.Price, 0),
                        CreatedDate: structures.dateTimeFormatJson(item.DateCreated),
                        Status: structures.getStatus(item.Status)
                    });
                    if (render != '') {
                        $('#tbl-content').html(render);
                    }
                });
            },
            error: function (status) {
                console.log(status);
                structures.notify('Không thể tải dữ liệu','error')
            }
        })
    }
}
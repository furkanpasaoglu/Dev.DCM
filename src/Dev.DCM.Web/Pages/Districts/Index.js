$(function () {
    var l = abp.localization.getResource('DCM');
    var createModal = new abp.ModalManager(abp.appPath + 'Districts/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'Districts/EditModal');
    
    var dataTable = $('#DistrictsTable').DataTable(
        abp.libs.datatables.normalizeConfiguration({
            serverSide: true,
            paging: true,
            order: [[1, "asc"]],
            searching: false,
            scrollX: true,
            ajax: function(data, callback, settings) {
                abp.libs.datatables.createAjax(dev.dCM.services.districts.district.getList)(data, callback, settings);
            },
            columnDefs: [
                {
                    title: l('Id'),
                    data: "id",
                    visible: false
                },
                {
                    title: l('CityName'),
                    data: "city.name"
                },
                {
                    title: l('Code'),
                    data: "code"
                },
                {
                    title: l('Name'),
                    data: "name"
                },
                {
                    title: l('Actions'),
                    rowAction: {
                        items:
                            [
                                {
                                    text: l('Edit'),
                                    visible: abp.auth.isGranted('DCM.Location.District.Edit'),
                                    action: function (data) {
                                        editModal.open({ id: data.record.id });
                                    }
                                },
                                {
                                    text: l('Delete'),
                                    visible: abp.auth.isGranted('DCM.Location.District.Delete'),
                                    confirmMessage: function (data) {
                                        return l('DistrictDeletionConfirmationMessage', data.record.name);
                                    },
                                    action: function (data) {
                                        dev.dCM.services.districts.district
                                            .delete(data.record.id)
                                            .then(function() {
                                                abp.notify.info(l('SuccessfullyDeleted'));
                                                dataTable.ajax.reload();
                                            });
                                    }
                                }
                            ]
                    }
                }
            ]
        })
    );

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });
    
    $('#NewDistrictButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });

});
$(function () {
    var l = abp.localization.getResource('DCM');
    var createModal = new abp.ModalManager(abp.appPath + 'IdentityTypes/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'IdentityTypes/EditModal');
    
    var dataTable = $('#IdentityTypesTable').DataTable(
        abp.libs.datatables.normalizeConfiguration({
            serverSide: true,
            paging: true,
            order: [[1, "asc"]],
            searching: false,
            scrollX: true,
            ajax: function(data, callback, settings) {
                abp.libs.datatables.createAjax(dev.dCM.services.identityTypes.identityType.getList)(data, callback, settings);
            },
            columnDefs: [
                {
                    title: l('Id'),
                    data: "id",
                    visible: false
                },
                {
                    title: l('No'),
                    data: "no",
                },
                {
                    title: l('Name'),
                    data: "name"
                },
                {
                    title: l('CountryCode'),
                    data: "countryCode"
                },
                {
                    title: l('TypeCode'),
                    data: "typeCode"
                },
                {
                    title: l('SerialNo'),
                    data: "serialNo"
                },
                {
                    title: l('IdentityNo'),
                    data: "identityNo"
                },
                {
                    title: l('Actions'),
                    rowAction: {
                        items:
                            [
                                {
                                    text: l('Edit'),
                                    visible: abp.auth.isGranted('DCM.IdentityType.Edit'),
                                    action: function (data) {
                                        editModal.open({ id: data.record.id });
                                    }
                                },
                                {
                                    text: l('Delete'),
                                    visible: abp.auth.isGranted('DCM.IdentityType.Delete'),
                                    confirmMessage: function (data) {
                                        return l('IdentityTypeDeletionConfirmationMessage', data.record.name);
                                    },
                                    action: function (data) {
                                        dev.dCM.services.identityTypes.identityType
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
    
    $('#NewIdentityTypeButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
    
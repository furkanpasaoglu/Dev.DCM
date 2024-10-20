$(function () {
    var l = abp.localization.getResource('DCM');
    var createModal = new abp.ModalManager(abp.appPath + 'Parameters/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'Parameters/EditModal');
    
    var dataTable = $('#ParametersTable').DataTable(
        abp.libs.datatables.normalizeConfiguration({
            serverSide: true,
            paging: true,
            order: [[1, "asc"]],
            searching: false,
            scrollX: true,
            ajax: function(data, callback, settings) {
                abp.libs.datatables.createAjax(dev.dCM.services.parameters.parameter.getList)(data, callback, settings);
            },
            columnDefs: [
                {
                    title: l('Id'),
                    data: "id",
                    visible: false
                },
                {
                    title: l('Name'),
                    data: "name"
                },
                {
                    title: l('Value'),
                    data: "value"
                },
                {
                    title: l('Description'),
                    data: "description"
                },
                {
                    title: l('Actions'),
                    rowAction: {
                        items:
                            [
                                {
                                    text: l('Edit'),
                                    visible: abp.auth.isGranted('DCM.Parameter.Edit'),
                                    action: function (data) {
                                        editModal.open({ id: data.record.id });
                                    }
                                },
                                {
                                    text: l('Delete'),
                                    visible: abp.auth.isGranted('DCM.Parameter.Delete'),
                                    confirmMessage: function (data) {
                                        return l('ParameterDeletionConfirmationMessage', data.record.name);
                                    },
                                    action: function (data) {
                                        dev.dCM.services.parameters.parameter
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

    $('#NewParameterButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });

});
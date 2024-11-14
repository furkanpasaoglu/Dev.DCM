$(function () {
    var l = abp.localization.getResource('DCM');
    var createModal = new abp.ModalManager(abp.appPath + 'LineStatusCodes/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'LineStatusCodes/EditModal');
    
    var dataTable = $('#LineStatusCodesTable').DataTable(
        abp.libs.datatables.normalizeConfiguration({
            serverSide: true,
            paging: true,
            order: [[1, "asc"]],
            searching: false,
            scrollX: true,
            ajax: function(data, callback, settings) {
                abp.libs.datatables.createAjax(dev.dCM.services.lineStatusCodes.lineStatusCode.getList)(data, callback, settings);
            },
            columnDefs: [
                {
                    title: l('Id'),
                    data: "id",
                    visible: false
                },
                {
                    title: l('Code'),
                    data: "code"
                },
                {
                    title: l('Status'),
                    data: "status"
                },
                {
                    title: l('StatusDescription'),
                    data: "statusDescription"
                },
                {
                    title: l('Actions'),
                    rowAction: {
                        items:
                            [
                                {
                                    text: l('Edit'),
                                    visible: abp.auth.isGranted('DCM.Types.LineStatusCodes.Edit'),
                                    action: function (data) {
                                        editModal.open({ id: data.record.id });
                                    }
                                },
                                {
                                    text: l('Delete'),
                                    visible: abp.auth.isGranted('DCM.Types.LineStatusCodes.Delete'),
                                    confirmMessage: function (data) {
                                        return l('LineStatusCodeDeletionConfirmationMessage', data.record.name);
                                    },
                                    action: function (data) {
                                        dev.dCM.services.lineStatusCodes.lineStatusCode
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
    
    $('#NewLineStatusCodeButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
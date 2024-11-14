$(function () {
    var l = abp.localization.getResource('DCM');
    var createModal = new abp.ModalManager(abp.appPath + 'CustomerMovementCodes/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'CustomerMovementCodes/EditModal');

    var dataTable = $('#CustomerMovementCodesTable').DataTable(
        abp.libs.datatables.normalizeConfiguration({
            serverSide: true,
            paging: true,
            order: [[1, "asc"]],
            searching: false,
            scrollX: true,
            ajax: function(data, callback, settings) {
                abp.libs.datatables.createAjax(dev.dCM.services.customerMovementCodes.customerMovementCode.getList)(data, callback, settings);
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
                    title: l('Description'),
                    data: "description"
                },
                {
                    title: l('ProcessingMethod'),
                    data: "processingMethod"
                },
                {
                    title: l('Actions'),
                    rowAction: {
                        items:
                            [
                                {
                                    text: l('Edit'),
                                    visible: abp.auth.isGranted('DCM.Types.CustomerMovementCodes.Edit'),
                                    action: function (data) {
                                        editModal.open({ id: data.record.id });
                                    }
                                },
                                {
                                    text: l('Delete'),
                                    visible: abp.auth.isGranted('DCM.CustomerMovementCodes.Delete'),
                                    confirmMessage: function (data) {
                                        return l('CustomerMovementCodeDeletionConfirmationMessage', data.record.name);
                                    },
                                    action: function (data) {
                                        dev.dCM.services.customerMovementCodes.customerMovementCode
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

    $('#NewCustomerMovementCodeButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
$(function () {
    var l = abp.localization.getResource('DCM');
    var createModal = new abp.ModalManager(abp.appPath + 'TenantDetails/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'TenantDetails/EditModal');
    
    var dataTable = $('#TenantDetailsTable').DataTable(
        abp.libs.datatables.normalizeConfiguration({
            serverSide: true,
            paging: true,
            order: [[1, "asc"]],
            searching: false,
            scrollX: true,
            ajax: function(data, callback, settings) {
                abp.libs.datatables.createAjax(dev.dCM.services.tenantDetails.tenantDetail.getList)(data, callback, settings);
            },
            columnDefs: [
                {
                    title: l('Id'),
                    data: "id",
                    visible: false
                },
                {
                    title: l('TenantName'),
                    data: "tenant.name"
                },
                {
                    title: l('CompanyName'),
                    data: "name"
                },
                {
                    title: l('OperatorCode'),
                    data: "operatorCode"
                },
                {
                    title: l('TaxNumber'),
                    data: "taxNumber"
                },
                {
                    title: l('Actions'),
                    rowAction: {
                        items:
                            [
                                {
                                    text: l('Edit'),
                                    visible: abp.auth.isGranted('DCM.TenantDetail.Edit'),
                                    action: function (data) {
                                        editModal.open({ id: data.record.id });
                                    }
                                },
                                {
                                    text: l('Delete'),
                                    visible: abp.auth.isGranted('DCM.TenantDetail.Delete'),
                                    confirmMessage: function (data) {
                                        return l('TenantDetailsDeletionConfirmationMessage', data.record.tenant.name);
                                    },
                                    action: function (data) {
                                        dev.dCM.services.tenantDetails.tenantDetail
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

    $('#NewTenantDetailsButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });

});
    
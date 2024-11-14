$(function () {
    var l = abp.localization.getResource('DCM');
    var createModal = new abp.ModalManager(abp.appPath + 'ServiceTypes/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'ServiceTypes/EditModal');

    var dataTable = $('#ServiceTypesTable').DataTable(
        abp.libs.datatables.normalizeConfiguration({
            serverSide: true,
            paging: true,
            order: [[1, "asc"]],
            searching: false,
            scrollX: true,
            ajax: function(data, callback, settings) {
                abp.libs.datatables.createAjax(dev.dCM.services.serviceTypes.serviceType.getList)(data, callback, settings);
            },
            columnDefs: [
                {
                    title: l('Id'),
                    data: "id",
                    visible: false,
                },
                {
                    title: l('No'),
                    data: "no"
                },
                {
                    title: l('BusinessType'),
                    data: "businessType"
                },
                {
                    title: l('InfrastructureType'),
                    data: "infrastructureType",
                },
                {
                    title: l('ServiceTypeValue'),
                    data: "serviceTypeValue"
                },
                {
                    title: l('ValueDescription'),
                    data: "valueDescription"
                },
                {
                    title: l('IsActive'),
                    data: "isActive"
                },
                {
                    title: l('Actions'),
                    rowAction: {
                        items:
                            [
                                {
                                    text: l('Edit'),
                                    visible: abp.auth.isGranted('DCM.Types.ServiceTypes.Edit'),
                                    action: function (data) {
                                        editModal.open({ id: data.record.id });
                                    }
                                },
                                {
                                    text: l('Delete'),
                                    visible: abp.auth.isGranted('DCM.Types.ServiceTypes.Delete'),
                                    confirmMessage: function (data) {
                                        return l('ServiceTypeDeletionConfirmationMessage', data.record.name);
                                    },
                                    action: function (data) {
                                        dev.dCM.services.serviceTypes.serviceType
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

    $('#NewServiceTypeButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
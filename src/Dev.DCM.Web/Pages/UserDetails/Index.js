$(function () {
    var l = abp.localization.getResource('DCM');
    var createModal = new abp.ModalManager(abp.appPath + 'UserDetails/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'UserDetails/EditModal');
    
    var dataTable = $('#UserDetailsTable').DataTable(
        abp.libs.datatables.normalizeConfiguration({
            serverSide: true,
            paging: true,
            order: [[1, "asc"]],
            searching: false,
            scrollX: true,
            ajax: function(data, callback, settings) {
                abp.libs.datatables.createAjax(dev.dCM.services.userDetails.userDetail.getList)(data, callback, settings);
            },
            columnDefs: [
                {
                    title: l('Id'),
                    data: "id",
                    visible: false
                },
                {
                    title: l('IdentityNumber'),
                    data: "identityNumber"
                },
                {
                    title: l('BirthDate'),
                    data: "birthDate"
                },
                {
                    title: l('PhoneNumber'),
                    data: "phoneNumber"
                },
                {
                    title: l('Users'),
                    data: "user.name"
                },
                {
                    title: l('Actions'),
                    rowAction: {
                        items:
                            [
                                {
                                    text: l('Edit'),
                                    visible: abp.auth.isGranted('DCM.UserDetails.Edit'),
                                    action: function (data) {
                                        editModal.open({ id: data.record.id });
                                    }
                                },
                                {
                                    text: l('Delete'),
                                    visible: abp.auth.isGranted('DCM.UserDetails.Delete'),
                                    confirmMessage: function (data) {
                                        return l('UserDetailDeletionConfirmationMessage', data.record.name);
                                    },
                                    action: function (data) {
                                        dev.dCM.services.userDetails.userDetail
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
    
    $('#NewUserDetailButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });

});
    
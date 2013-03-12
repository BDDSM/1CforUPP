var windowIndex = 0;

Ext.define('MyDesktop.BogusModule',
{
    extend: 'Ext.ux.desktop.Module',

    init: function ()
    {
        this.launcher =
        {
            text: 'Window ' + (++windowIndex),
            iconCls: 'bogus',
            handler: this.createWindow,
            scope: this,
            windowId: windowIndex
        }
    },
    createWindow: function (src) {
        Ext.Loader.setConfig({ //������������ ���������� ��������
            enabled: true,  //��������� �������
            disableCaching: true,   //�� �������� �����
            paths: {
                Base: "js/Base", //���� � ������������ ������ Base
                ����������: "����������",
                �����������: "�����������"
            }
        });
        //alert(src.FormId);
        var win = Ext.create(src.FormId, {
            // grid: this
            //������� �������� ����, ������������ � ����� Test, ���� ������ ������������� ����������     this.tbar = new App.Common.CommonGridTBar({grid:this});
            //items:[{
            //    xtype:'form',
            //    items:[{
            //        xtype:'textfield',
            //        fieldLabel:'fdsfds'
            //    }]
            //}]
        });
        win.show();
        return win;
    }
});


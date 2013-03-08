/*!
* Ext JS Library 4.0
* Copyright(c) 2006-2011 Sencha Inc.
* licensing@sencha.com
* http://www.sencha.com/license
*/

var windowIndex = 0;

Ext.define('MyDesktop.BogusModule', {
    extend: 'Ext.ux.desktop.Module',

    init: function () {
        this.launcher = {
            text: 'Window ' + (++windowIndex),
            iconCls: 'bogus',
            handler: this.createWindow,
            scope: this,
            windowId: windowIndex
        }
    },

    createWindow1 : function(src){
        var desktop = this.app.getDesktop();
        var win = desktop.getWindow('bogus'+src.windowId);
        if(!win){
            win = desktop.createWindow({
                id: 'bogus'+src.windowId,
                title:src.text,
                width:640,
                height:480,
                html : '<p>Something useful would be in here.</p>',
                iconCls: 'bogus',
                animCollapse:false,
                constrainHeader: true

            });
        }
        win.show();
        return win;
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


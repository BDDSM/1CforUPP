﻿Ext.define('Справочники.РегламентированныеОтчеты.ФормаГруппы',
	{
	extend: 'Ext.window.Window',
	height: 306,width: 322,
	iconCls: 'bogus',
	title: 'Группа отчетов',
	
	items: [
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Наименование',
			style: 'position:absolute;left:94px;top:8px;width:220px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Описание',
			style: 'position:absolute;left:8px;top:53px;width:306px;height:220px;',
		},
	]
});
﻿Ext.define('Справочники.НематериальныеАктивы.ФормаГруппы',
	{
	extend: 'Ext.window.Window',
	height: 112,width: 414,
	iconCls: 'bogus',
	title: 'Группа Нематериальные активы и расходы на НИОКР',
	
	items: [
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Код',
			style: 'position:absolute;left:366px;top:60px;width:40px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Наименование',
			style: 'position:absolute;left:102px;top:60px;width:220px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Родитель',
			style: 'position:absolute;left:102px;top:33px;width:304px;height:19px;',
		},
	]
});
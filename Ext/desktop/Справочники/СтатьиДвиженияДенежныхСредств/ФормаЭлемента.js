﻿Ext.define('Справочники.СтатьиДвиженияДенежныхСредств.ФормаЭлемента',
	{
	extend: 'Ext.window.Window',
	height: 143,width: 497,
	iconCls: 'bogus',
	title: 'Статьи движения денежных средств',
	
	items: [
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Код',
			style: 'position:absolute;left:409px;top:33px;width:80px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Наименование',
			style: 'position:absolute;left:119px;top:33px;width:244px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Родитель',
			style: 'position:absolute;left:119px;top:91px;width:205px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ВидДвиженияДенежныхСредств',
			style: 'position:absolute;left:119px;top:56px;width:370px;height:19px;',
		},
	]
});
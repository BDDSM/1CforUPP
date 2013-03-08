﻿Ext.define('Справочники.ИсточникиДанныхДляРасчетовБюджетирования.ФормаГруппы',
	{
	extend: 'Ext.window.Window',
	height: 113,width: 406,
	iconCls: 'bogus',
	title: 'Группа Источники данных для расчетов бюджетирования',
	
	items: [
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Код',
			style: 'position:absolute;left:317px;top:61px;width:81px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Наименование',
			style: 'position:absolute;left:93px;top:61px;width:183px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Родитель',
			style: 'position:absolute;left:93px;top:33px;width:305px;height:19px;',
		},
	]
});
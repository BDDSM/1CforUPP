
using System;
using V82;
using V82.СправочникиСсылка;
using V82.ДокументыСсылка;
using V82.ДокументыОбъект;
using V82.Перечисления;//Ссылка;
namespace V82.ДокументыОбъект
{
	///<summary>
	///(Общ)
	///</summary>
	public partial class ПлатежныйОрдерПоступлениеДенежныхСредств:ДокументОбъект
	{
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Валюты ВалютаДокумента;//Валюта документа
		///<summary>
		///(Общ)
		///</summary>
		public object РасчетныйДокумент;//Расчетный документ
		///<summary>
		///(Общ)
		///</summary>
		public V82.Перечисления/*Ссылка*/.ВидыОперацийПоступлениеБезналичныхДенежныхСредств ВидОперации;//Вид операции
		///<summary>
		///(Общ)
		///</summary>
		public string/*(30)*/ НомерВходящегоДокумента;//Номер входящего документа
		///<summary>
		///(Общ)
		///</summary>
		public DateTime ДатаВходящегоДокумента;//Дата входящего документа
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.ДоговорыКонтрагентов ДоговорКонтрагента;//Договор контрагента
		///<summary>
		///(Общ)
		///</summary>
		public object ДокументОснование;//Документ основание
		///<summary>
		///(Общ) Любая дополнительная информация
		///</summary>
		public string/*(0)*/ Комментарий;
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Контрагенты Контрагент;//Плательщик
		///<summary>
		///(Общ)
		///</summary>
		public bool Оплачено;
		///<summary>
		///(Общ)
		///</summary>
		public bool ОтраженоВОперУчете;//Отражено в опер. учете
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Организации Организация;
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Пользователи Ответственный;
		///<summary>
		///(Общ)
		///</summary>
		public bool ОтражатьВБухгалтерскомУчете;//Отражать в бухгалтерском учете
		///<summary>
		///(Общ)
		///</summary>
		public bool ОтражатьВНалоговомУчете;//Отражать в налоговом учете
		///<summary>
		///(Регл)
		///</summary>
		public V82.СправочникиСсылка.СтатьиДвиженияДенежныхСредств СтатьяДвиженияДенежныхСредств;//Статья движения денежных средств
		///<summary>
		///(Упр)
		///</summary>
		public DateTime ДатаОплаты;//Дата оплаты
		///<summary>
		///(Регл)
		///</summary>
		public object СубконтоКт1;//Субконто Кт1
		///<summary>
		///(Регл)
		///</summary>
		public object СубконтоКт2;//Субконто Кт1
		///<summary>
		///(Регл)
		///</summary>
		public object СубконтоКт3;//Субконто Кт1
		///<summary>
		///(Общ)
		///</summary>
		public decimal/*(15.2)*/ СуммаДокумента;//Сумма документа
		///<summary>
		///(Общ) Банковский счет контрагента
		///</summary>
		public V82.СправочникиСсылка.БанковскиеСчета СчетКонтрагента;//Счет контрагента
		///<summary>
		///(Общ) Банковский счет организации
		///</summary>
		public V82.СправочникиСсылка.БанковскиеСчета СчетОрганизации;//Счет организации
		///<summary>
		///(Регл)
		///</summary>
		public object СчетУчетаРасчетовСКонтрагентом;//Счет учета расчетов с контрагентом
		public string/*(200)*/ Содержание_УСН;//Содержание УСН
		public decimal/*(15.2)*/ Графа4_УСН;//Графа4 УСН
		public decimal/*(15.2)*/ Графа5_УСН;//Графа5 УСН
		public decimal/*(15.2)*/ Графа6_УСН;//Графа5
		public decimal/*(15.2)*/ Графа7_УСН;//Графа5
		public bool ДоходыЕНВД_УСН;//ДоходыЕНВД
		public bool РасходыЕНВД_УСН;//Расходы ЕНВД УСН
		public V82.СправочникиСсылка.Подразделения Подразделение;
		public decimal/*(15.2)*/ НДС_УСН;//НДС УСН
		public bool РучнаяНастройка_УСН;//Ручная настройка УСН
		public bool ОтражатьРазницуВКурсеВСоставеОперационныхРасходов;//Отражать разницу в курсе в составе операционных расходов
		///<summary>
		///(Регл)
		///</summary>
		public object СчетУчетаРасчетовСКонтрагентомНУ;//Счет учета расчетов с контрагентом НУ
		///<summary>
		///(Регл)
		///</summary>
		public object СубконтоНУКт1;//Субконто НУ Кт1
		///<summary>
		///(Регл)
		///</summary>
		public object СубконтоНУКт2;//Субконто НУ Кт2
		///<summary>
		///(Регл)
		///</summary>
		public object СубконтоНУКт3;//Субконто НУ Кт3
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.СтатьиЗатрат СтатьяЗатрат;//Статья затрат
		///<summary>
		///(Упр)
		///</summary>
		public V82.СправочникиСсылка.НоменклатурныеГруппы НоменклатурнаяГруппа;//Номенклатурная группа
		///<summary>
		///(Упр)
		///</summary>
		public V82.СправочникиСсылка.Подразделения ПодразделениеЗатраты;//Подразделение (затраты)
		///<summary>
		///(Регл)
		///</summary>
		public V82.СправочникиСсылка.ПодразделенияОрганизаций ПодразделениеОрганизацииЗатраты;//Подразделение организации затраты
		public decimal/*(10.4)*/ КурсНаДатуПриобретенияРеализацииВалюты;//Курс на дату приобретения реализации валюты
		///<summary>
		///(Общ)
		///</summary>
		public string/*(0)*/ НазначениеПлатежа;//Назначение платежа
		public decimal/*(15.2)*/ СуммаУслуг;//Сумма услуг
	}
}
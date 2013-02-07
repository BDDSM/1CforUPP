
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
	public partial class РасходныйКассовыйОрдер:ДокументОбъект
	{
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Организации Организация;
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Кассы Касса;
		///<summary>
		///(Упр)
		///</summary>
		public V82.СправочникиСсылка.Подразделения Подразделение;
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Пользователи Ответственный;
		///<summary>
		///(Общ)
		///</summary>
		public string/*(0)*/ Выдать;
		///<summary>
		///(Общ)
		///</summary>
		public string/*(0)*/ Основание;
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.ДоговорыКонтрагентов ДоговорКонтрагента;//договор контрагента
		///<summary>
		///(Общ) Валюта, в которой подотчетник должен отчитаться за истраченные деньги
		///</summary>
		public V82.СправочникиСсылка.Валюты ВалютаВзаиморасчетовРаботника;//Валюта взаиморасчетов работника
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Валюты ВалютаДокумента;//Валюта документа
		///<summary>
		///(Общ)
		///</summary>
		public string/*(0)*/ Приложение;
		///<summary>
		///(Упр) срок погашения аванса подотчетником
		///</summary>
		public DateTime ДатаПогашенияАванса;//Дата погашения аванса
		///<summary>
		///(Упр)
		///</summary>
		public object РасчетныйДокумент;//Расчетный документ
		///<summary>
		///(Общ)
		///</summary>
		public string/*(0)*/ ПоДокументу;//По
		///<summary>
		///(Общ)
		///</summary>
		public bool ОтражатьВУправленческомУчете;//Отражать в управленческом учете
		///<summary>
		///(Общ)
		///</summary>
		public bool ОтражатьВБухгалтерскомУчете;//Отражать в бухгалтерском учете
		///<summary>
		///(Общ) Любая дополнительная информация
		///</summary>
		public string/*(0)*/ Комментарий;
		///<summary>
		///(Общ)
		///</summary>
		public bool ОтраженоВОперУчете;//Отражено в опер. учете
		///<summary>
		///(Общ)
		///</summary>
		public bool Оплачено;
		///<summary>
		///(Общ)
		///</summary>
		public object Контрагент;//Контрагент, подотчетник, Касса ККМ
		///<summary>
		///(Общ)
		///</summary>
		public V82.Перечисления/*Ссылка*/.ВидыОперацийРКО ВидОперации;//Вид операции
		///<summary>
		///(Общ) Сумма в валюте документа, налоги включены согласно флагам
		///</summary>
		public decimal/*(15.2)*/ СуммаДокумента;//Сумма документа
		///<summary>
		///(Общ)
		///</summary>
		public object ДокументОснование;//Документ основание
		///<summary>
		///(Общ)
		///</summary>
		public bool ОтражатьВНалоговомУчете;//Отражать в налоговом учете
		///<summary>
		///(Регл)
		///</summary>
		public object СубконтоДт1;//Субконто Дт1
		///<summary>
		///(Регл)
		///</summary>
		public object СубконтоДт2;//Субконто Дт1
		///<summary>
		///(Регл)
		///</summary>
		public object СубконтоДт3;//Субконто Дт1
		///<summary>
		///(Регл)
		///</summary>
		public object СчетУчетаРасчетовСКонтрагентом;//Счет учета расчетов с контрагентом
		///<summary>
		///(Регл)
		///</summary>
		public V82.СправочникиСсылка.СтатьиДвиженияДенежныхСредств СтатьяДвиженияДенежныхСредств;//Статья движения денежных средств
		///<summary>
		///(Общ)  Банковский счет организации
		///</summary>
		public V82.СправочникиСсылка.БанковскиеСчета СчетОрганизации;//Счет организации
		public string/*(200)*/ Содержание_УСН;//Содержание УСН
		public decimal/*(15.2)*/ Графа4_УСН;//Графа4 УСН
		public decimal/*(15.2)*/ Графа5_УСН;//Графа5 УСН
		public decimal/*(15.2)*/ Графа6_УСН;//Графа5
		public decimal/*(15.2)*/ Графа7_УСН;//Графа5
		public bool ДоходыЕНВД_УСН;//ДоходыЕНВД
		public bool РасходыЕНВД_УСН;//Расходы ЕНВД УСН
		public decimal/*(15.2)*/ НДС_УСН;//НДС УСН
		public bool РучнаяНастройка_УСН;//Ручная настройка УСН
		public V82.Перечисления/*Ссылка*/.ВидВыдачиДенежныхСредств ВидВыдачиДенежныхСредств;//Вид выдачи денежных средств
		public V82.ДокументыСсылка.ОбъявлениеНаВзносНаличными ОбъявлениеНаВзносНаличными;//Объявление на взнос наличными
		///<summary>
		///Номер чека на фискальном регистраторе
		///</summary>
		public decimal/*(8)*/ НомерЧекаККМ;//Номер чека ККМ
		///<summary>
		///(Регл)
		///</summary>
		public object СчетУчетаРасчетовСКонтрагентомНУ;//Счет учета расчетов с контрагентом НУ
		///<summary>
		///(Регл)
		///</summary>
		public object СубконтоНУДт1;//Субконто НУДт1
		///<summary>
		///(Регл)
		///</summary>
		public object СубконтоНУДт2;//Субконто НУДт2
		///<summary>
		///(Регл)
		///</summary>
		public object СубконтоНУДт3;//Субконто НУДт3
	}
}
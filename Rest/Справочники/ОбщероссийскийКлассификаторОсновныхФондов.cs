
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/ObshherossijjskijjKlassifikatorOsnovnykhFondov")]
	[Route("/Catalogs/ObshherossijjskijjKlassifikatorOsnovnykhFondov/{Code}")]
	public class ObshherossijjskijjKlassifikatorOsnovnykhFondovRequest/*�����������������������������������������������*/: V82.�����������������.�����������������������������������������,IReturn<ObshherossijjskijjKlassifikatorOsnovnykhFondovRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class ObshherossijjskijjKlassifikatorOsnovnykhFondovResponse//����������������������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/ObshherossijjskijjKlassifikatorOsnovnykhFondovs")]
	[Route("/Catalogs/ObshherossijjskijjKlassifikatorOsnovnykhFondovs/{Codes}")]
	public class ObshherossijjskijjKlassifikatorOsnovnykhFondovsRequest/*�����������������������������������������������*/: IReturn<List<ObshherossijjskijjKlassifikatorOsnovnykhFondovRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public ObshherossijjskijjKlassifikatorOsnovnykhFondovsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class ObshherossijjskijjKlassifikatorOsnovnykhFondovsResponse//����������������������������������������������
	{
		public string Result {get;set;}
	}


	public class ObshherossijjskijjKlassifikatorOsnovnykhFondovService /*�����������������������������������������������*/ : Service
	{
		public object Any(ObshherossijjskijjKlassifikatorOsnovnykhFondovRequest request)
		{
			return new ObshherossijjskijjKlassifikatorOsnovnykhFondovResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(ObshherossijjskijjKlassifikatorOsnovnykhFondovRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�����������������������������������������.�����������(���������);
				if (������ == null)
				{
					return new ObshherossijjskijjKlassifikatorOsnovnykhFondovResponse() {Result = "����������������������������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�����������������������������������������.�����������(1);
			}
		}

		public object Get(ObshherossijjskijjKlassifikatorOsnovnykhFondovsRequest request)
		{
			var ��������� = new List<V82.�����������������.�����������������������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.�����������������������������������������.�����������(���������);
					if (������ != null)
					{
						���������.Add(������);
					}
				}
			}
			return ���������;
		}

	}
}

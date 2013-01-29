
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/UchetnyeZapisiEHlektronnojjPochty")]
	[Route("/Catalogs/UchetnyeZapisiEHlektronnojjPochty/{Code}")]
	public class UchetnyeZapisiEHlektronnojjPochtyRequest/*�����������������������������������*/: V82.�����������������.�����������������������������,IReturn<UchetnyeZapisiEHlektronnojjPochtyRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class UchetnyeZapisiEHlektronnojjPochtyResponse//����������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/UchetnyeZapisiEHlektronnojjPochtys")]
	[Route("/Catalogs/UchetnyeZapisiEHlektronnojjPochtys/{Codes}")]
	public class UchetnyeZapisiEHlektronnojjPochtysRequest/*�����������������������������������*/: IReturn<List<UchetnyeZapisiEHlektronnojjPochtyRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public UchetnyeZapisiEHlektronnojjPochtysRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class UchetnyeZapisiEHlektronnojjPochtysResponse//����������������������������������
	{
		public string Result {get;set;}
	}


	public class UchetnyeZapisiEHlektronnojjPochtyService /*�����������������������������������*/ : Service
	{
		public object Any(UchetnyeZapisiEHlektronnojjPochtyRequest request)
		{
			return new UchetnyeZapisiEHlektronnojjPochtyResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(UchetnyeZapisiEHlektronnojjPochtyRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�����������������������������.�����������(���������);
				if (������ == null)
				{
					return new UchetnyeZapisiEHlektronnojjPochtyResponse() {Result = "����������������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�����������������������������.�����������(1);
			}
		}

		public object Get(UchetnyeZapisiEHlektronnojjPochtysRequest request)
		{
			var ��������� = new List<V82.�����������������.�����������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.�����������������������������.�����������(���������);
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


using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/GruppyDostupaFizicheskikhLic")]
	[Route("/Catalogs/GruppyDostupaFizicheskikhLic/{Code}")]
	public class GruppyDostupaFizicheskikhLicRequest/*��������������������������������*/: V82.�����������������.��������������������������,IReturn<GruppyDostupaFizicheskikhLicRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class GruppyDostupaFizicheskikhLicResponse//�������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/GruppyDostupaFizicheskikhLics")]
	[Route("/Catalogs/GruppyDostupaFizicheskikhLics/{Codes}")]
	public class GruppyDostupaFizicheskikhLicsRequest/*��������������������������������*/: IReturn<List<GruppyDostupaFizicheskikhLicRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public GruppyDostupaFizicheskikhLicsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class GruppyDostupaFizicheskikhLicsResponse//�������������������������������
	{
		public string Result {get;set;}
	}


	public class GruppyDostupaFizicheskikhLicService /*��������������������������������*/ : Service
	{
		public object Any(GruppyDostupaFizicheskikhLicRequest request)
		{
			return new GruppyDostupaFizicheskikhLicResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(GruppyDostupaFizicheskikhLicRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.��������������������������.�����������(���������);
				if (������ == null)
				{
					return new GruppyDostupaFizicheskikhLicResponse() {Result = "�������������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.��������������������������.�����������(1);
			}
		}

		public object Get(GruppyDostupaFizicheskikhLicsRequest request)
		{
			var ��������� = new List<V82.�����������������.��������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.��������������������������.�����������(���������);
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

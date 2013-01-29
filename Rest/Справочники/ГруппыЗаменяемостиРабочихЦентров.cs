
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/GruppyZamenyaemostiRabochikhCentrov")]
	[Route("/Catalogs/GruppyZamenyaemostiRabochikhCentrov/{Code}")]
	public class GruppyZamenyaemostiRabochikhCentrovRequest/*��������������������������������������*/: V82.�����������������.��������������������������������,IReturn<GruppyZamenyaemostiRabochikhCentrovRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class GruppyZamenyaemostiRabochikhCentrovResponse//�������������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/GruppyZamenyaemostiRabochikhCentrovs")]
	[Route("/Catalogs/GruppyZamenyaemostiRabochikhCentrovs/{Codes}")]
	public class GruppyZamenyaemostiRabochikhCentrovsRequest/*��������������������������������������*/: IReturn<List<GruppyZamenyaemostiRabochikhCentrovRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public GruppyZamenyaemostiRabochikhCentrovsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class GruppyZamenyaemostiRabochikhCentrovsResponse//�������������������������������������
	{
		public string Result {get;set;}
	}


	public class GruppyZamenyaemostiRabochikhCentrovService /*��������������������������������������*/ : Service
	{
		public object Any(GruppyZamenyaemostiRabochikhCentrovRequest request)
		{
			return new GruppyZamenyaemostiRabochikhCentrovResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(GruppyZamenyaemostiRabochikhCentrovRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.��������������������������������.�����������(���������);
				if (������ == null)
				{
					return new GruppyZamenyaemostiRabochikhCentrovResponse() {Result = "�������������������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.��������������������������������.�����������(1);
			}
		}

		public object Get(GruppyZamenyaemostiRabochikhCentrovsRequest request)
		{
			var ��������� = new List<V82.�����������������.��������������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.��������������������������������.�����������(���������);
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

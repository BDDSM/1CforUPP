
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/VidyObsluzhivaniyaOsnovnykhSredstv")]
	[Route("/Catalogs/VidyObsluzhivaniyaOsnovnykhSredstv/{Code}")]
	public class VidyObsluzhivaniyaOsnovnykhSredstvRequest/*�������������������������������������*/: V82.�����������������.�������������������������������,IReturn<VidyObsluzhivaniyaOsnovnykhSredstvRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class VidyObsluzhivaniyaOsnovnykhSredstvResponse//������������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/VidyObsluzhivaniyaOsnovnykhSredstvs")]
	[Route("/Catalogs/VidyObsluzhivaniyaOsnovnykhSredstvs/{Codes}")]
	public class VidyObsluzhivaniyaOsnovnykhSredstvsRequest/*�������������������������������������*/: IReturn<List<VidyObsluzhivaniyaOsnovnykhSredstvRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public VidyObsluzhivaniyaOsnovnykhSredstvsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class VidyObsluzhivaniyaOsnovnykhSredstvsResponse//������������������������������������
	{
		public string Result {get;set;}
	}


	public class VidyObsluzhivaniyaOsnovnykhSredstvService /*�������������������������������������*/ : Service
	{
		public object Any(VidyObsluzhivaniyaOsnovnykhSredstvRequest request)
		{
			return new VidyObsluzhivaniyaOsnovnykhSredstvResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(VidyObsluzhivaniyaOsnovnykhSredstvRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�������������������������������.�����������(���������);
				if (������ == null)
				{
					return new VidyObsluzhivaniyaOsnovnykhSredstvResponse() {Result = "������������������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�������������������������������.�����������(1);
			}
		}

		public object Get(VidyObsluzhivaniyaOsnovnykhSredstvsRequest request)
		{
			var ��������� = new List<V82.�����������������.�������������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.�������������������������������.�����������(���������);
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

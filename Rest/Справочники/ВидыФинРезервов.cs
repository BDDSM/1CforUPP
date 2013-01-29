
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/VidyFinRezervov")]
	[Route("/Catalogs/VidyFinRezervov/{Code}")]
	public class VidyFinRezervovRequest/*���������������������*/: V82.�����������������.���������������,IReturn<VidyFinRezervovRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class VidyFinRezervovResponse//��������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/VidyFinRezervovs")]
	[Route("/Catalogs/VidyFinRezervovs/{Codes}")]
	public class VidyFinRezervovsRequest/*���������������������*/: IReturn<List<VidyFinRezervovRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public VidyFinRezervovsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class VidyFinRezervovsResponse//��������������������
	{
		public string Result {get;set;}
	}


	public class VidyFinRezervovService /*���������������������*/ : Service
	{
		public object Any(VidyFinRezervovRequest request)
		{
			return new VidyFinRezervovResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(VidyFinRezervovRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.���������������.�����������(���������);
				if (������ == null)
				{
					return new VidyFinRezervovResponse() {Result = "��������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.���������������.�����������(1);
			}
		}

		public object Get(VidyFinRezervovsRequest request)
		{
			var ��������� = new List<V82.�����������������.���������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.���������������.�����������(���������);
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

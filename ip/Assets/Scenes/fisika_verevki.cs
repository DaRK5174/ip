using UnityEngine;

public class SwingObjectYAxis : MonoBehaviour
{
    [Header("Настройки раскачивания")]
    [Tooltip("Скорость раскачивания")]
    [SerializeField] private float swingSpeed = 1f;

    [Tooltip("Максимальный угол в градусах")]
    [SerializeField][Range(0, 180)] private float maxAngle = 145f;

    [Tooltip("Задержка перед началом движения (секунды)")]
    [SerializeField] private float startDelay = 0f;

    private Quaternion initialRotation;
    private float timer = 0f;
    private bool isDelayed = true;

    void Start()
    {
        initialRotation = transform.rotation;

        if (startDelay > 0)
            Invoke("StartSwinging", startDelay);
        else
            isDelayed = false;
    }

    void Update()
    {
        if (isDelayed) return;

        timer += Time.deltaTime * swingSpeed;
        float smoothFactor = Mathf.Clamp01(timer) * 0.5f + 0.5f;
        float angle = Mathf.Sin(timer) * maxAngle * smoothFactor;
        transform.rotation = initialRotation * Quaternion.Euler(0f, angle, 0f);
    }

    private void StartSwinging()
    {
        isDelayed = false;
    }
}

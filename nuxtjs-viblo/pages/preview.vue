<template>
  <div class="detail">
    <div class="detail-form-block">
      <div class="detail-form-content-block">
        <div
          class=""
          v-for="(phase, index) in form.phases"
          :key="index"
          v-show="currentPhaseIndex === index"
        >
          <div class="">
            <div class="">
              {{ phase.title }}
            </div>
            <div class="">
              {{ phase.description }}
            </div>
          </div>
          <div v-for="(item, index) in phase.items" :key="index">
            <component
              :is="currentComponent"
              v-bind="currentItem"
              :item="item"
            ></component>
            <!-- <div class="">
              {{ item.name }}
            </div>
            <div class="">
              {{ item.description }}
            </div>
            <input type="text" width="100%"  /> -->
          </div>
        </div>
        <div class="">
          <div class="">
            <button>Lưu chỉnh sửa</button>
            <button @click="previos">Phần trước</button>
            <button @click="next">Phần tiếp theo</button>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>
<script>
import { v4 as uuidv4 } from "uuid";
import EmailFormPreview from "~/components/item-component/email/EmailFormPreview.vue";

export default {
  components: {EmailFormPreview},
  props: {
    groupIndex: Number,
  },
  data() {
    return {
      form: [],
      emailItem: null,
      activeGroupIndex: null,
      currentPhaseIndex: 0,
      currentItemIndex:0,
    };
  },
  mounted() {
    this.loadFromLocalStorage();
  },
  computed: {
    currentComponent() {
      // get the type of the current item to determine which component to display
      return `${this.currentItem.type_name}FormPreview`;
    },
    currentItem() {
      // get the current item based on the current index
      return this.form.phases[this.currentPhaseIndex].items[this.currentItemIndex];
    },
  },
  methods: {
    goBack() {
      this.$router.go(-1);
    },

    save() {
      if (this.emailItem.is_create == true) {
        this.create();
      } else {
        this.update();
      }
      localStorage.setItem("myObject", JSON.stringify(this.form));
      this.goBack();
    },
    loadFromLocalStorage() {
      const savedObject = localStorage.getItem("myObject");
      if (savedObject) {
        this.form = JSON.parse(savedObject);
      }
    },
    findItem() {
      const a = this.form.phases.filter((row) => {
        return row;
      });
      const b = this.item.id;
      for (var i = 0; i < a.length; i++) {
        a[i].items.forEach((element) => {
          if (element.id == b) {
            console.log(element);
            this.emailItem = element;
          }
        });
      }
    },
    next() {
      if (this.currentPhaseIndex < this.form.phases.length - 1) {
        this.currentPhaseIndex++;
      }
    },
    previos() {
      if (this.currentPhaseIndex > 0) {
        this.currentPhaseIndex--;
      }
    },
  },
};
</script>
<style scoped>
@import "../assets/css/preview/preview.css";
</style>
